using car_factory.Car;
using car_factory.Car.Type;
using car_factory.Machines;
using System;
using System.Collections.Generic;

namespace car_factory.Factory
{
    class CarFactory
    {

        public static Batch CreateBatch(CarType type, int size)
        {
            var batch = new Batch
            {
                Size = size,
                Type = type
            };
            for (int i = 0; i < batch.Size; i++)
            {
                batch.AddCar(type);
            }
            return batch;
        }

        public static void PaintBatch(Batch batch, string paint)
        {
            Console.WriteLine("Starting Painting");
            var iterator = batch.GetIterator();
            var paintingMachine = PaintingMachine.Instance;
            while (iterator.HasNext())
            {
                paintingMachine.Paint(iterator.Next(), paint);
            }
            Console.WriteLine("Painting Completed");
        }

        public static void PaintBatch(Batch batch, List<string> paint)
        {
            if (batch.Count!=batch.Size)
            {
                Console.WriteLine("batch not ready");
                return;
            }
            else if (batch.Size!=paint.Count)
            {
                Console.WriteLine("Paint count messed");
                return;
            }else
            {
                Console.WriteLine("Starting Painting");
                var iterator = batch.GetIterator();
                var paintingMachine = PaintingMachine.Instance;
                var paintEnumerator = paint.GetEnumerator();
                while (paintEnumerator.MoveNext())
                {
                    paintingMachine.Paint(iterator.Next(), paintEnumerator.Current);
                   
                }
                Console.WriteLine("Painting Completed");
            }
        }

        public static void PrintBatchDetails(Batch batch)
        {
            Console.WriteLine("Batch Details\n\n");

            Console.WriteLine("Batch Size:"+ batch.Size);
            Console.WriteLine("Batch Manufactured Count:"+ batch.Count);
            Console.WriteLine("Batch Vehicle Type:"+batch.Type);

            Console.WriteLine("Print Car details individually? (Y/N)");
            var print = Console.ReadLine();
            if (print=="Y"||print=="y")
            {
                var iterator = batch.GetIterator();
                while (iterator.HasNext())
                {
                    Console.WriteLine(iterator.Next().ToString());
                }
            }
        }
    }
}