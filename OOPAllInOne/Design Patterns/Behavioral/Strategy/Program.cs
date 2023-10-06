// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bir uygulamada, bir nesnenin fonksiyonu içerisinde kullanılan algoritma akışının her zaman sabit olmadığını fark ettiniz. Gelecekte bu algoritmanın değişmesi durumunda söz konusu fonksiyona MÜDAHALE ETMEDEN, fonksiyonun çalışma stratejisini nasıl değiştirirsiniz?
 *   
 *   
 *   Senaryo:
 *   
 *      Bir koleksiyonu belirli sıralama algoritması ile sıralamak istiyorsunuz. Gelecekte algoritma güncellendiğinde, doğrudan sıralama fonksiyonuna uygulamalısınız:
 *
 */

BubbleSort bubbleSort = new BubbleSort();
ClassRoom room = new ClassRoom();

room.SortStudents(bubbleSort);

Quick quick = new Quick();

room.SortStudents(quick);

Heap heap = new Heap();

room.SortStudents(heap);