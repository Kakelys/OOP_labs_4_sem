using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    [Serializable]
    [DataContract]
    internal class Prototype<T>
    {

        public virtual T Clone()
        {
            return (T) MemberwiseClone();
        }

        public virtual T DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var context =
                    new StreamingContext(StreamingContextStates.Clone);
                var formatter =
                    new BinaryFormatter { Context = context };
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
