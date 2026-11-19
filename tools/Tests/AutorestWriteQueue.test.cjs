const assert = require('node:assert/strict');
const fs = require('node:fs');
const os = require('node:os');
const path = require('node:path');
const vm = require('node:vm');
const test = require('node:test');
const createWriteQueue = require('../Utilities/autorest-write-queue.cjs');
const patchCore = require('../Utilities/Patch-AutorestCore.cjs');

test('bounds outstanding writes to 32 and preserves completion and arguments', async () => {
    let active = 0;
    let peak = 0;
    const releases = [];
    const calls = [];
    const write = createWriteQueue((...args) => {
        calls.push(args);
        peak = Math.max(peak, ++active);
        return new Promise(resolve => releases.push(() => {
            active--;
            resolve(args[0]);
        }));
    });
    const writes = Array.from({ length: 101 }, (_, i) => write(`file-${i}`, `content-${i}`, 'utf8'));
    await new Promise(setImmediate);
    assert.equal(calls.length, 32);
    while (calls.length < 101 || releases.length > 0) {
        releases.splice(0).forEach(release => release());
        await new Promise(setImmediate);
    }
    assert.equal(peak, 32);
    assert.deepEqual(await Promise.all(writes), Array.from({ length: 101 }, (_, i) => `file-${i}`));
    assert.deepEqual(calls[100], ['file-100', 'content-100', 'utf8']);
});

test('propagates rejected writes and synchronous errors without blocking the queue', async () => {
    const failure = new Error('disk write failed');
    const write = createWriteQueue(i => {
        if (i === 0) { throw failure; }
        return i === 1 ? Promise.reject(failure) : Promise.resolve(i);
    });
    const results = await Promise.allSettled(Array.from({ length: 70 }, (_, i) => write(i)));
    assert.equal(results[0].reason, failure);
    assert.equal(results[1].reason, failure);
    assert.equal(results[69].value, 69);
});

test('patches both write sites idempotently and rejects unexpected core layouts', () => {
    const root = fs.mkdtempSync(path.join(os.tmpdir(), 'graph-autorest-patch-test-'));
    try {
        fs.mkdirSync(path.join(root, 'dist'));
        const manifest = path.join(root, 'package.json');
        const bundle = path.join(root, 'dist', 'src_lib_autorest-core_ts.js');
        fs.writeFileSync(manifest, JSON.stringify({ name: '@autorest/core', version: '3.10.4' }));
        fs.writeFileSync(bundle, 'fs_1.promises.writeFile(this.item.name, this.item.cached);\nfs_1.default.promises.writeFile(this.filename, content);');
        patchCore(root);
        const patched = fs.readFileSync(bundle, 'utf8');
        patchCore(root);
        assert.equal(fs.readFileSync(bundle, 'utf8'), patched);
        assert.equal(patched.match(/graphSdkWriteFile\(/g).length, 2);
        new vm.Script(patched);
        fs.writeFileSync(bundle, 'changed upstream implementation');
        assert.throws(() => patchCore(root), /Unexpected AutoREST/);
        fs.writeFileSync(manifest, JSON.stringify({ name: '@autorest/core', version: '3.10.5' }));
        assert.throws(() => patchCore(root), /Unsupported AutoREST/);
    }
    finally {
        fs.rmSync(root, { recursive: true, force: true });
    }
});
