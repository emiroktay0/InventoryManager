
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    internal class Inventory
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int CurrentSlotId { get; set; } = 1;

        


        
        


        public Inventory(int w, int h)
        {
            Width = w; Height = h;
            
        }

        public void Init()
        {
            int count = 1;
            
            for (int i = 0; i < Height; i++) 
            {
                bool isXOutOfBonds = false;
                Console.Write(" ");
                for(int j = 0; j < Width; j++)
                {
                    Console.Write("--- ");
                }

                Console.WriteLine();
                
                for(int k = 0; k <= Width; k++)
                {
                    if (count == CurrentSlotId)
                    {
                        if(count % Width == 1 && !isXOutOfBonds)
                        {
                            Console.Write("| X ");
                        }
                        if(count % Width != 1)
                            Console.Write("| X ");
                        if (count % Width == 1 && isXOutOfBonds)
                            Console.Write("|   ");
                    }
                    else
                    {
                        Console.Write("|   ");
                        isXOutOfBonds = true;
                    }
                    

                    count++;
                    
                }
                Console.WriteLine();
                count--;


            }
            Console.Write(" ");
            for (int j = 0; j < Width; j++)
            {
                Console.Write("--- ");
            }

        }


        


    }
}
