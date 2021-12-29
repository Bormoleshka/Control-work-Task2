// Task2.

Random rand = new Random();
           int count=0;
           
            int [] arr = new int[15];//создали массив
             
            
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = rand.Next(1, 50);
                Console.Write(arr[i] + " ");
                    if(arr[i] > 8)
                        count++;
            }
            Console.WriteLine();//выводим получившийся массив
             if (count <= 8)
                Console.WriteLine("числа больше 8 отсутствуют");
            else
            {
                
                int j = 0;
                int[] arr1 = new int[count];
                Console.WriteLine("массив чисел больше 8:");
                for(int i=0; i<arr.Length; i++)
                {
                    if (arr[i] > 8)
                    {
                        arr1[j]=arr[i];
                        Console.Write(arr1[j]+" ");
                        j++;
                    }
                }
            }
            Console.ReadKey();//выводим требуемый массив из четных чисел
 
