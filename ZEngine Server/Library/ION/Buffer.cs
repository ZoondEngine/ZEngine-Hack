using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.ION.Exceptions;

namespace ZEngine_Server.Library.ION
{
    class Buffer
    {
        MemoryStream stream;
        BinaryWriter bw;
        BinaryReader br;

        public Buffer()
        {
            stream = new MemoryStream();
            bw = new BinaryWriter(stream);
            br = new BinaryReader(stream);
        }

        public Buffer(byte[] data)
        {
            stream = new MemoryStream(data);
            bw = new BinaryWriter(stream);
            br = new BinaryReader(stream);
        }

        public void Write<T>(T value)
        {
            if (typeof(T) == typeof(byte))
            {
                bw.Write((byte)(object)value);
            }
            else if(typeof(T) == typeof(byte[]))
            {
                bw.Write((byte[])(object)value);
            }
            else if (typeof(T) == typeof(int))
            {
                bw.Write((int)(object)value);
            }
            else if (typeof(T) == typeof(string))
            {
                bw.Write((string)(object)value);
            }
            else if(typeof(T) == typeof(bool))
            {
                bw.Write((bool)(object)value);
            }
            else
            {
                throw new NetworkBufferException($"Incorrect type('{typeof(T)}') for writing in buffer.");
            }
        }

        public T Read<T>()
        {
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)br.ReadByte();
            }
            else if (typeof(T) == typeof(int))
            {
                return (T)(object)br.ReadInt32();
            }
            else if (typeof(T) == typeof(string))
            {
                return (T)(object)br.ReadString();
            }
            else
            {
                throw new NetworkBufferException($"Incorrect type('{typeof(T)}') for reading in buffer.");
            }
        }

        public byte[] GetData()
        {
            return stream.ToArray();
        }

        public int Tell()
        {
            return (int)stream.Position;
        }

        public void SeekStart()
        {
            stream.Seek(0, SeekOrigin.Begin);
        }

        public void Clear()
        {
            bw.Close();
            bw.Dispose();
            stream.Close();
            stream.Dispose();
        }
    }
}
