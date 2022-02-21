using System;

namespace Fitness.BL.Model
{
    public class Gender
    {
        // Пол.
        public string Name { get; }

        // Название.

        public Gender(string name)
        {
            // Создать новый пол
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
