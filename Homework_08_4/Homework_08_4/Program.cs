// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Запрашиваем данные о контакте у пользователя
        Console.WriteLine("Введите данные о контакте:");

        Console.Write("ФИО: ");
        string name = Console.ReadLine();

        Console.Write("Улица: ");
        string street = Console.ReadLine();

        Console.Write("Номер дома: ");
        string houseNumber = Console.ReadLine();

        Console.Write("Номер квартиры: ");
        string flatNumber = Console.ReadLine();

        Console.Write("Мобильный телефон: ");
        string mobilePhone = Console.ReadLine();

        Console.Write("Домашний телефон: ");
        string homePhone = Console.ReadLine();

        // Создаем XML с помощью XElement
        XElement contactElement = new XElement("Person",
            new XAttribute("name", name),
            new XElement("Address",
                new XElement("Street", street),
                new XElement("HouseNumber", houseNumber),
                new XElement("FlatNumber", flatNumber)
            ),
            new XElement("Phones",
                new XElement("MobilePhone", mobilePhone),
                new XElement("HomePhone", homePhone)
            )
        );

        // Сохраняем XML в файл
        contactElement.Save("contact.xml");

        Console.WriteLine("Данные успешно сохранены в файл contact.xml.");
    }
}

