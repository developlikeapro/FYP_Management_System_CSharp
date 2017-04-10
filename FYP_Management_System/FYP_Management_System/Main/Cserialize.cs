using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Management_System
{
    class Cserialization
    {
        public Cserialization()
        {
            Mserialize(new Ccontroler());
        }

        public Ccontroler Mdeserialize()
        {
            Ccontroler newobj=null;
            FileStream fs = new FileStream("db.bat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                newobj = (Ccontroler)formatter.Deserialize(fs);
            }
            catch (Exception)
            {
                return null;
            }
           
            return newobj;
        }
        public void Mserialize(Ccontroler obj)
        {
            FileStream fs = new FileStream("db.bat", FileMode.OpenOrCreate);
            
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, obj);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Faile    d to serialize . Reason: "+ex.ToString());
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
