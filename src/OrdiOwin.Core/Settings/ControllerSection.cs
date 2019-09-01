using System.Configuration;

namespace OrdiOwin.Core.Settings
{
    public class ControllerSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public ControllerElementCollection Controllers
        {
            get { return (ControllerElementCollection)this[""]; }
        }

        public static ControllerSection GetSection()
        {
            return ConfigurationManager.GetSection("controllers") as ControllerSection;
        }
    }

    public class ControllerElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ControllerElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            ControllerElement controllerElement = (ControllerElement)element;
            return controllerElement.ControllerName;
        }
    }

    public class ControllerElement : ConfigurationElement
    {
        [ConfigurationProperty("controllerName", IsRequired = true)]
        public string ControllerName
        {
            get { return (string)this["controllerName"]; }
            set { this["controllerName"] = value; }
        }
    }
}
