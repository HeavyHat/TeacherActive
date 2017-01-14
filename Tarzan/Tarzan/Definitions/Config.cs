using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Tarzan.Definitions
{
    class Config
    {
        protected string filePath;

        protected readonly IList<ConfigNode> topLevelNodes;
            
        public Config()
        {
            topLevelNodes = new List<ConfigNode>();
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/TeacherActive/";
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            filePath += "config.xml";
            if (!File.Exists(filePath))
                File.Create(filePath);
            BuildFromConfigFile(filePath);
        }

        private void BuildFromConfigFile(string path)
        {
            XmlDocument xmlConfigFile = new XmlDocument();
            xmlConfigFile.Load(path);
            foreach (XmlNode node in xmlConfigFile.ChildNodes) 
                topLevelNodes.Add(new ConfigNode(node));
        }

        protected ConfigNode FindNode(string nodeToSearchFor)
        {
            foreach(var topLevelNode in topLevelNodes)
            {
                var foundNode = topLevelNode.FindChildNode(nodeToSearchFor);
                var found = foundNode != null;
                if (found)
                    return foundNode;
            }
            return null;
        }

        public ConfigNode this[string keyToLookFor]
        {
            get
            {
                return FindNode(keyToLookFor);
            }
        }
    }
}
