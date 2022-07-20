using System;
using Core.Constants;
using Core.Entities;
using Core.Helpers;
using DataAccess.Repositories.Implementations;

namespace Manage
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupRepository _groupRepository = new GroupRepository();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Welcome");
            Console.WriteLine("-----");

            while (true)
            {
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Group");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Group");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Group");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "4 - All Groups");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Group by name");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                Console.WriteLine("-----");
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Gray, "Select option");
            string number = Console.ReadLine();

            int selectedNumber;
            bool result = int.TryParse(number, out selectedNumber);

                if (result)
                {
                    if (selectedNumber >= 0 && selectedNumber <=5)
                    {
                        switch (selectedNumber)
                        {
                            case (int)Options.CreateGroup:
                                ConsoleHelper.WriteTextWithColor(ConsoleColor.Magenta, "Enter group name");
                                string name = Console.ReadLine();
                                MaxSize:  ConsoleHelper.WriteTextWithColor(ConsoleColor.Magenta, "Enter group max size");
                                string size = Console.ReadLine();
                                int maxSize;
                                result = int.TryParse(size, out maxSize);
                                if (result)
                                {
                                    Group group = new Group
                                    {
                                        Name = name,
                                        MaxSize = maxSize
                                    };
                                    _groupRepository.Create(group);
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, $"{group.Name} is succesfully created with max size - {group.MaxSize}");
                                }
                                else
                                {
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please, enter correct group maxsize");
                                    goto MaxSize;
                                }
                                break;
                            case (int)Options.UpdateGroup:
                                break;
                            case (int)Options.DeleteGroup:
                                break;
                            case (int)Options.AllGroups:
                                break;
                            case (int)Options.GetGroupByName:
                                break;
                            case (int)Options.Exit:
                                break;
                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please, enter correct number");
                    }
                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Please, enter correct number");
                }
            }



        }
    }
}
