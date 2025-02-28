using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Project
{
    class Node
    {
		int data;
		Node LChild;
		Node RChild;
		Node Parent;
		public int gsdata
		{
			get
			{
				return data;
			}
			set
			{
				data = value;
			}
		}
		public Node gsLChild
		{
			get
			{
				return LChild;
			}
			set
			{
				LChild = value;
			}
		}
		public Node gsRChild
		{
			get
			{
				return RChild;
			}
			set
			{
				RChild = value;
			}
		}
		public Node gsParent
		{
			get
			{
				return Parent;
			}
			set
			{
				Parent = value;
			}
		}
	}
}

