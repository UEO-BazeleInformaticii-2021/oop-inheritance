using System;

namespace OopInheritance
{
    public class File
    {
        public File(string name, string extension)
        {
            this.Name = name;
            this.Extension = extension;
        }

        public string Name
        {
            get;
        }

        public string Extension
        {
            get;
        }

        public void Open()
        {
            Console.WriteLine($"Opening file '{this.Name}.{this.Extension}'");
        }
    }
}
