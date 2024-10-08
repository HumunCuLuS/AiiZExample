class Program
{

    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Enter your words...");
            var words = Console.ReadLine();
            Console.WriteLine("output: " + string.Join(", ", WordSegment(words)));

            Console.Write("Do you want to add another word? (y/n): ");
            string response = Console.ReadLine().ToLower();
            if (response.ToLower() == "n")
            {
                continueProgram = false;
                Console.WriteLine("Exiting the program...");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("");
        }
    }


    // ฟังก์ชันสำหรับตัดคำออกจาก input string
    static string[] WordSegment(string input)
    {
        // คำที่ใช้ตรวจสอบ
        string[] words = { "apple", "fruit", "orange", "pie", "aiiz" };

        //เก็บผลลัพธ์
        List<string> result = new List<string>();

        // สร้าง temp string เพื่อทำการตัดคำ
        string temp = input;

        // ตัดคำทีละคำ
        foreach (var word in words)
        {
            // หากคำที่ตรวจเจออยู่ใน temp string
            while (temp.Contains(word))
            {
                result.Add(word);           // เพิ่มคำที่เจอใน result
                int index = temp.IndexOf(word);  // หาตำแหน่งของคำที่เจอ
                temp = temp.Remove(index, word.Length);  // ลบคำออกจาก temp
            }
        }

        // return คำที่ตัดได้ทั้งหมด
        if (result.Count() > 0)
        {
            return result.ToArray();   
        }
        else
        {
            return new string[] { "Not found" };  //แสดงว่าไม่เจอคำที่ต้องการ
        }
    }
}