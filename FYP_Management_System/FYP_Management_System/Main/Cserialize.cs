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
        public Cserialization(ref Ccontroler obj)
        {
            obj =Mdeserialize();
            if (obj==null)
            {
                obj = Mdeserialize();
            }
        }

        public Ccontroler Mdeserialize()
        {
            Ccontroler newobj=null;
            FileStream fs = new FileStream("db.bat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                newobj = (Ccontroler)formatter.Deserialize(fs);
            }
            catch (Exception)
            {
                fs.Close();
                Mserialize(new Ccontroler());
                return null;

            }
            finally
            {
                fs.Close();
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
                Console.WriteLine("Failed to serialize . Reason: "+ex.ToString());
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
