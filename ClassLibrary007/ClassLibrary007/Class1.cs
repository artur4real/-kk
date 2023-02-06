using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamok1
{
    public class Class1
    {
        string castlename; //название замка
        int currentlevelHP; // текущее здоровье 
        int max_damage; // максимальный уровень 
        int max_level_HP; // максимальный уровень здоровья

        public int СurrentlevelHP
        {
            get { return currentlevelHP; } // возвращает значение 
            set { currentlevelHP = value; } // задает значение 

        }

        public int Max_damage
        {
            get { return max_damage; } // возвращает значение 
            set { max_damage = value; } // задает значение 

        }
        public int Max_level_HP
        {
            get { return max_level_HP; } // возвращает значение 
            set { max_level_HP = value; } // задает значение 



        }
    }
}
