// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

const fs = require('node:fs');
const path = require('node:path');

function patchCore(corePath) {
    const manifest = JSON.parse(fs.readFileSync(path.join(corePath, 'package.json'), 'utf8'));
    if (manifest.name !== '@autorest/core' || manifest.version !== '3.10.4') {
        throw new Error(`Unsupported AutoREST core at ${corePath}: expected @autorest/core 3.10.4`);
    }
    const filename = path.join(corePath, 'dist', 'src_lib_autorest-core_ts.js');
    const header = 'const graphSdkWriteFile = require("./graph-sdk-write-queue.cjs")(require("fs").promises.writeFile);\n';
    const replacements = [
        ['fs_1.promises.writeFile(this.item.name, this.item.cached)', 'graphSdkWriteFile(this.item.name, this.item.cached)'],
        ['fs_1.default.promises.writeFile(this.filename, content)', 'graphSdkWriteFile(this.filename, content)'],
    ];
    let content = fs.readFileSync(filename, 'utf8');
    const patched = content.startsWith(header);
    for (const [before, after] of replacements) {
        const expected = patched ? after : before;
        if (content.split(expected).length !== 2 || content.includes(patched ? before : after)) {
            throw new Error(`Unexpected AutoREST cache-write implementation in ${filename}: ${expected}`);
        }
    }
    fs.copyFileSync(path.join(__dirname, 'autorest-write-queue.cjs'), path.join(corePath, 'dist', 'graph-sdk-write-queue.cjs'));
    if (!patched) {
        for (const [before, after] of replacements) {
            content = content.replace(before, after);
        }
        fs.writeFileSync(filename, header + content);
    }
    console.log(`AutoREST core temporary writes limited to 32 per process: ${corePath}`);
}

if (require.main === module) {
    patchCore(process.argv[2] || path.resolve(__dirname, '..', '..', 'node_modules', '@autorest', 'core'));
}

module.exports = patchCore;
