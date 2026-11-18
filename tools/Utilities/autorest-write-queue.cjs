// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

module.exports = function createWriteQueue(writeFile) {
    let active = 0;
    const pending = [];

    function drain() {
        while (active < 32 && pending.length > 0) {
            const { args, resolve, reject } = pending.shift();
            active++;
            Promise.resolve()
                .then(() => writeFile(...args))
                .then(resolve, reject)
                .finally(() => {
                    active--;
                    drain();
                });
        }
    }

    return (...args) => new Promise((resolve, reject) => {
        pending.push({ args, resolve, reject });
        drain();
    });
};
