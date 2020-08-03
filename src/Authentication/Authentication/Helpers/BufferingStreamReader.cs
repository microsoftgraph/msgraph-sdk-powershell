// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal class BufferingStreamReader : Stream
    {
        internal BufferingStreamReader(Stream baseStream)
        {
            _baseStream = baseStream;
            _streamBuffer = new MemoryStream();
            _length = long.MaxValue;
            _copyBuffer = new byte[4096];
        }

        private readonly Stream _baseStream;
        private readonly MemoryStream _streamBuffer;
        private readonly byte[] _copyBuffer;

        public override bool CanRead => true;

        public override bool CanSeek => true;

        public override bool CanWrite => false;

        public override void Flush()
        {
            _streamBuffer.SetLength(0);
        }

        public override long Length => _length;

        private long _length;

        public override long Position
        {
            get => _streamBuffer.Position;

            set => _streamBuffer.Position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var previousPosition = Position;
            var consumedStream = false;
            var totalCount = count;
            while ((!consumedStream) &&
                   ((Position + totalCount) > _streamBuffer.Length))
            {
                // If we don't have enough data to fill this from memory, cache more.
                // We try to read 4096 bytes from base stream every time, so at most we
                // may cache 4095 bytes more than what is required by the Read operation.
                var bytesRead = _baseStream.Read(_copyBuffer, 0, _copyBuffer.Length);

                if (_streamBuffer.Position < _streamBuffer.Length)
                {
                    // Win8: 651902 no need to -1 here as Position refers to the place
                    // where we can start writing from.
                    _streamBuffer.Position = _streamBuffer.Length;
                }

                _streamBuffer.Write(_copyBuffer, 0, bytesRead);

                totalCount -= bytesRead;
                if (bytesRead < _copyBuffer.Length)
                {
                    consumedStream = true;
                }
            }

            // Reset our backing store to its official position, as reading
            // for the CopyTo updates the position.
            _streamBuffer.Seek(previousPosition, SeekOrigin.Begin);

            // Read from the backing store into the requested buffer.
            var read = _streamBuffer.Read(buffer, offset, count);

            if (read < count)
            {
                SetLength(Position);
            }

            return read;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _streamBuffer.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _length = value;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }
    }
}