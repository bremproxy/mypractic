using System.Windows.Forms;
using System;
using Microsoft.VisualBasic;

class firstnameAge
{
    static void Main()
    {

        string name, age1;
        int year = 2022, age, born, a;
        name = Interaction.InputBox("Как тебя зовут?");
        age1 = Interaction.InputBox("Какой год твоего рождения?");
        bool result = int.TryParse(age1, out born);
        if (result)
        {
           MessageBox.Show("Отлично," + born);
           age = year - born;
           name="Получаеться, Вам "+name+" "+age+" лет!";
           MessageBox.Show(name, "Магия!!!");
        }
        else
        {
           MessageBox.Show("Ты ввел какую то дичь, давай досвиданья " + born);
        }
    }

}