using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Project
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("input a data for your tree root");
			int root = Convert.ToInt32(Console.ReadLine());
			BinaryTree bt = new BinaryTree(root);
			string command;
			Console.WriteLine("input a number between 0 to 5 and if you need help,input 6");
			while (true)
			{
				command = Console.ReadLine();
				switch (command)
				{
					case "0":
						{
							Environment.Exit(0);
						}
						break;
					case "1":
						{
							Console.WriteLine("input parent");
							int parent = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("input data");
							int data = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("input L for left or R for right");
							char LorR = Convert.ToChar(Console.ReadLine());
							bt.AddNode(bt.gsroot, parent, data, LorR);
						}
						break;
					case "2":
						{
							Console.WriteLine("input data");
							int data = Convert.ToInt32(Console.ReadLine());
							bt.DeleteNode(bt.gsroot, data);
						}
						break;
					case "3":
						{
							Console.WriteLine("inorder:");
							bt.inorder(bt.gsroot);
						}
						break;
					case "4":
						{
							Console.WriteLine("postorder");
							bt.postorder(bt.gsroot);
						}
						break;
					case "5":
						{
							Console.WriteLine("preorder");
							bt.preorder(bt.gsroot);
						}
						break;
					case "6":
						{
							Console.WriteLine("input 0 fot quit");
							Console.WriteLine("input 1 for add node for your tree");
							Console.WriteLine("input 2 for delete node");
							Console.WriteLine("input 3 for inorder");
							Console.WriteLine("input 4 for postorder");
							Console.WriteLine("input 5 for preorder");
						}
						break;
					default:
						{
							Console.WriteLine("input number between 0 to 6");
						}
						break;
				}
			}
		}
    }
}
