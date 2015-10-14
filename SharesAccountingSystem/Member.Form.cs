using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharesBusiness;

namespace SharesAccountingSystem
{
    internal class MemberUI
    {
        public void AddNew()
        {
            try
            {
                Member newMember = new Member(@"D:\ParaCustomer.txt");

                //Member newMember1 = new Member(MemberTitle.Mr, "Ajay", "Sharma", MemberType.Nominal, @"D:\ParaCustomer.txt");

                char addConfirmation = 'N';
                char newEntryConfirmation = 'N';

                do
                {
                    foreach (MemberTitle i in Enum.GetValues(typeof(MemberTitle)))
                    {
                        Console.WriteLine("{0} - {1}", Convert.ToInt32(i), i);
                    }
                    Console.Write("Member Title: ");
                    newMember.Title = (MemberTitle)Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");

                    Console.Write("First Name: ");
                    newMember.FirstName = Convert.ToString(Console.ReadLine());
                    Console.Write("\n");

                    Console.Write("Last Name: ");
                    newMember.LastName = Convert.ToString(Console.ReadLine());
                    Console.Write("\n");
                    
                    foreach (MemberType i in Enum.GetValues(typeof(MemberType)))
                    {
                        Console.WriteLine("{0} - {1}", Convert.ToInt32(i), i);
                    }
                    Console.Write("Member Type: ");
                    newMember.Type = (MemberType)Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");

                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.Write("Are you sure to add this customer? (Y/N): ");
                    addConfirmation = Convert.ToChar(Console.ReadLine());

                    if (addConfirmation.Equals('Y'))
                    {
                        if (newMember.Add()==0)
                        {
                            Console.Write("New Customer id added successfully. Do you want to add more customers? (Y/N): ");
                            newEntryConfirmation = Convert.ToChar(Console.ReadLine());
                            Console.Write("\n");
                        }
                    }

                } while (newEntryConfirmation.Equals('Y'));
            }
            catch
            {
                throw;
            }
        }

        public void GetAll()
        {
            try
            {
                Member newMember = new Member(@"D:\ParaCustomer.txt");
                List<Member> members = newMember.ViewAll();

                if (members != null && members.Count > 0)
                {

                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine("Title\t\tFirst Name\t\tLast Name\t\tType");
                    Console.WriteLine("-----------------------------------------------------------------------");
                    foreach (Member member in members)
                    {
                        Console.WriteLine(string.Concat(member.Title.ToString(), "\t\t", member.FirstName, "\t\t", member.LastName, "\t\t", member.Type.ToString()));
                        Console.WriteLine("-----------------------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.Write("No Members found...!!!");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
