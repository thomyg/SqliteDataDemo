using System;


namespace SqliteDataDemo.Data
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GenerateUIAttribute : Attribute
    {
      

        public GenerateUIAttribute()
        {

        }

    }
}
