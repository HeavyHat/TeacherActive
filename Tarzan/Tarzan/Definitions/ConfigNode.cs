using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tarzan.Definitions
{
    class ConfigNode
    {
        private readonly IList<ConfigNode> childrenNodes;
        private readonly IDictionary<string, string> attributes;
        private string innerText;
        private string nodeName;

        public ConfigNode()
        {
            childrenNodes = new List<ConfigNode>();
            attributes = new Dictionary<string, string>();
        }

        public ConfigNode(XmlNode element) : base()
        {
            var children = element.ChildNodes;
            foreach (XmlNode child in children)
            {
                childrenNodes.Add(new ConfigNode(child));
            }
            var allAttributes = element.Attributes;
            foreach (XmlAttribute attribute in allAttributes)
            {
                attributes[attribute.Name] = attribute.Value;
            }
            innerText = element.InnerText;
            nodeName = element.Name;
        }

        public bool IsTerminal
        {
            get { return childrenNodes.Count == 0; }
        }

        public string Text
        {
            get { return innerText; }
        }

        public string[] GetAttributes
        {
            get { return attributes.Keys.ToArray(); }
        }

        public string this[string attribute]
        {
            get { return attributes[attribute]; }
        }

        public ConfigNode FindChildNode(string nodeNameToLookFor)
        {
            if (nodeName.Equals(nodeNameToLookFor))
                return this;
            foreach (var childNode in childrenNodes)
            {
                var foundNode = childNode.FindChildNode(nodeNameToLookFor);
                var found = foundNode != null;
                if (found)
                    return foundNode;

            }
            return null;
        }
    }
}
