using Microsoft.Win32;
using System;

namespace RegistryLib
{
    public class Common
    {
        #region CONSTRUCTORS
        public Common(string programName)
        {
            this.baseRegistry = Registry.LocalMachine;
            this.subKey = string.Concat("SOFTWARE\\", programName, "\\");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRegistry">Sample: Registry.LocalMachine</param>
        /// <param name="subKey">Sample: "SOFTWARE\\[program_name]\\"</param>
        public Common(RegistryKey baseRegistry, string subKey)
        {
            this.baseRegistry = baseRegistry;
            this.subKey = subKey;
        }
        #endregion

        #region PROPERTIES

        private string subKey;
        public string SubKey
        {
            get { return subKey; }
            set { subKey = value; }
        }
        private RegistryKey baseRegistry;
        public RegistryKey RegistryKey
        {
            get { return baseRegistry; }
            set { baseRegistry = value; }
        }
        private Exception error;
        public Exception Error
        {
            get { return error; }
        }

        #endregion
        public object Read(string keyName)
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.OpenSubKey(subKey);
                if (key != null)
                {
                    return key.GetValue(keyName);
                }
            }
            catch (Exception e)
            {
                error = e;
            }
            return null;
        }
        public bool Write(string keyName, object value)
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.CreateSubKey(subKey);
                key.SetValue(keyName, value);
                return true;
            }
            catch (Exception e)
            {
                error = e;
            }
            return false;
        }
        public bool DeleteKey(string keyName)
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.CreateSubKey(subKey);
                if (key != null)
                {
                    key.DeleteValue(keyName);
                }
                return true;
            }
            catch (Exception e)
            {
                error = e;
            }
            return false;
        }
        public bool DeleteSubKeyTree()
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.OpenSubKey(subKey);
                if (key != null)
                {
                    baseRegistry.DeleteSubKeyTree(subKey);
                }
                return true;
            }
            catch (Exception e)
            {
                error = e;
            }
            return false;
        }
        public int SubKeyCount()
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.OpenSubKey(subKey);
                if (key != null)
                {
                    return key.SubKeyCount;
                }
            }
            catch (Exception e)
            {
                error = e;
            }
            return 0;
        }
        public int ValueCount()
        {
            try
            {
                error = null;
                RegistryKey key = baseRegistry.OpenSubKey(subKey);
                if (key != null)
                {
                    return key.ValueCount;
                }
            }
            catch (Exception e)
            {
                error = e;
            }
            return 0;
        }
    }

}
