using Lesson5HW;

var demo = new DemoHW();
Console.Write("Nhap tu can tim kiem: ");
string letter = Console.ReadLine();

string[] tiengAnh = { "book", "car", "pen", "cat", "dog", "home" };
string[] tiengViet = { "cuon sach", "xe hoi", "cay viet", "con meo", "con cho", "ngoi nha" };

demo.TraTu(letter, tiengAnh, tiengViet);

Console.ReadKey();