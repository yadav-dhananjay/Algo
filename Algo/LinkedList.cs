using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    public class LinkedList
    {
        private Node Head;

        public void stringtoFloat()
        {
            string key = Console.ReadLine();

            char[] input = key.ToCharArray();

            bool isDecimal = false;

            Int32 count = 1;
            float DecPos = 0;

            float dec;

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.') isDecimal = true;
                else
                {
                    DecPos = (float)(DecPos * 10) + ((input[i]) -48);
                    if (isDecimal) count *= 10;
                }
            }
            DecPos = DecPos / count;


        }

        public void FirstNode(object data)
        {
            var objAdd = new Node();

            objAdd.Data = data;
            objAdd.Next = Head;

            Head = objAdd;
        }

        public void ReverseAdd(object data)
        {
            if (Head == null)
            {
                var objAdd = new Node();

                objAdd.Data = data;

                objAdd.Next = Head;

                Head = objAdd;


            }
            else
            {
                var objAdd = new Node();
                objAdd.Data = data;

                Node current = Head;

                while (current.Next != null)
                {
                     current= current.Next;
                }


                current.Next = objAdd;
            }
        }


        public void removeNode(object data)
        {
            var prev = Head;
            var post = Head;

           // bool isExist = false;

            if (post.Data.Equals(data))
            {
                post = prev.Next;
            }
            else
            {
                while(prev.Next != null)
                {
                    if (prev.Data.Equals(data))
                    {
                        prev.Next = prev.Next.Next;
                        return;
                    }
                    prev = prev.Next;
                }
               // prev = prev.Next;
                //while(!(isExist=prev.Data.Equals(data)) && prev.Next != null)
                //{
                //   // isExist = prev.Data.Equals(data);

                //    post = prev;

                //    prev = prev.Next;
                //}

                //if (isExist)
                //{
                //    post.Next = prev.Next;
                //}

            }

            
        }

        public void DeleteNode(object item)
        {
            if (this.Head.Data.Equals(item))
            {
                Head = Head.Next;
            }
            else
            {
                var temp = Head;
                var tempPre = Head;
                bool matched = false;
                while (!(matched = temp.Data.Equals(item)) && temp.Next != null)
                {
                    tempPre = temp;
                    temp = temp.Next;
                }
                if (matched)
                {
                    tempPre.Next = temp.Next;
                }
                else
                {
                    Console.WriteLine("Value not found!");
                }
            }
        }

        public void SortList()
        {
            for(var i=Head; i!=null; i = i.Next)
            {
                for (var j = i.Next; j != null; j = j.Next)
                {
                    if (Convert.ToInt32(i.Data) > Convert.ToInt32(j.Data))
                    {
                        var temp = j.Data;
                        j.Data = i.Data;
                        i.Data = temp;
                    }

                }
            }
        }


        public void SortList2()
        {
            var i = Head;
            while ( i != null)
            {
                var j = i.Next;
                while ( j != null)
                {
                    if (Convert.ToInt32(i.Data) > Convert.ToInt32(j.Data))
                    {
                        var temp = j.Data;
                        j.Data = i.Data;
                        i.Data = temp;
                    }
                    j = j.Next;
                }
                i = i.Next;
            }
        }

        public void print()
        {
            var temp = Head;
            while (temp != null) { Console.WriteLine(temp.Data);temp = temp.Next; }
        }
    }

   public class Node
    {
        public Node Next;
        public Object Data;
    }

}
