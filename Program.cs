using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111111111111111
{
    
    internal class Program
    {

        static void Main(string[] args)
        {   /*
            变量类型 变量名
            int score;
            变量名=赋值
            score = 55;
            使用变量
            Console.WriteLine(score);
            Console.ReadKey();
            数据类型 变量名=值  
            int lifebalue = 3;
            Console.WriteLine(lifebalue);
            Console.ReadLine();*/

            /*
            把右边的15赋值给左边的age
            int age = 15;
            把YingHua和age相连
            string name ="YingHua";
            Console.WriteLine(name + age);
            Console.ReadLine(); */

            /*
            + - * / 加减乘除
            Console.WriteLine(5 + 8);      =13
            Console.WriteLine(555 - 8);    =547
            Console.WriteLine(5789 * 8);   =46312
            Console.WriteLine(10 / 3);     =3   两个整数相除会舍弃整数
            Console.WriteLine(10.0f / 3);  =3.333333 如果想要保留小数点就如前面所示 float类型要加f
            Console.ReadLine(); */

            /*
            计算三科总成绩和平均成绩
            float chinnese = 90;
            float english = 50;
            float math = 88;

            float total = chinnese + english + math;  总成绩
            float avg = total / 3;   //平均成绩  就是总成绩/3
            Console.WriteLine("总成绩" +total+"平均成绩"+avg);   //总成绩228平均成绩76
            Console.ReadLine(); */

            /*
            计算532 是由几个100 几个10  几个1 组成
            int day = 532;    
            int bai = day / 100;     //532/100=5 两个整数相除会舍弃小数点后面的数
            int shi =  (day % 100)/10; //用day取余（去掉）100 = 32;再用32 / 10 = 3
            int ge = day % 10;  //用day取余（去掉）10=2 把所有的数都除尽了 剩下最后一个数
            Console.WriteLine("百位是" + bai + "十位是" + shi + "个位是" + ge); //百位是5，十位是3，个位是2。
            Console.ReadLine(); */

            /*
            前++  后++
            int a = 111;
            int b = 323;
            a++;
            b++;
            Console.WriteLine("a" + a);  //112    单独使用 结果是变量加1
            Console.WriteLine("b" + b);  //324
            Console.ReadLine();
            int c = 10;
            int d = 10;
            int e = ++c; 
            int f = d++;     
            Console.WriteLine("d" + d);   //11
            Console.WriteLine("c" + c);   //11    配合使用  
            Console.WriteLine("e" + e);   //11    前++（++c）先给变量+1，再带着1去参与运算  [10+1=11;赋值给e;e=11]
            Console.WriteLine("f" + f);   //10    后++ (d++) 先拿原值参与运算，运算后在将变量+1 [先把值赋值给f，然后+1；f是10;f=10]          
            Console.ReadLine(); */

            /*
            +=  加等
            int num_1 = 10;
            num_1 += 5;         //两个相加等于15 +=要连起来用
            num_1 = num_1 + 5;  //简写式 第一个和第二个相加等于15
            Console.WriteLine(num_1);
            Console.ReadLine();

            -=  减等
            int num_2 = 20;
            num_2 -= 8;           //两个相减等于12 +=要连起来用
            num_2 = num_2 + 8;    //简写式 第一个和第二个相加等于12
            Console.WriteLine(num_2);
            Console.ReadLine();*/

            /*
            //>    大于
            Console.WriteLine(5 > 3);   //True 真 5>3是对的 所以是真的
            //<    小于
            Console.WriteLine(4 < 3);   //False 假 4<3是错的 所以是假的
            //>=   大于等于                                                                                              
            Console.WriteLine(10 >= 3);   //True 只要其中一个符号是对的，他就是真的
            Console.WriteLine(10 >= 10);  //True 比如10>3 10=10 是对的，他就是真的
            Console.WriteLine(10 >= 100); //False 即不大于100也不等于100，他就是假的
            //<=   小于等于
            Console.WriteLine(10 <= 12);  //True 只要其中一个符号是对的，他就是真的
            Console.WriteLine(10 <= 10);  //True 比如10<12 10=10 是对的，他就是真的
            //==   等于
            Console.WriteLine(10 == 12);  //False 在C#中等于是两个==号，他就是假的
            //!=   不等于
            Console.WriteLine(10 != 12);  //True  10不等于12，他就是真的
            Console.ReadLine();  */

            /*
            //逻辑与 &&
            Console.WriteLine(10 > 5 && 10 < 12); //true  两边结果为true,这个结果就为true.
            Console.WriteLine(3 > 5 && 10 > 7); //False  两边结果有一边为False，整个结果就为False.
            Console.ReadLine(); 

            //逻辑或 ||
            Console.WriteLine(10 > 3 || 3 > 10); //true  只要一边为true,结果就为true.
            Console.WriteLine(7 > 4 || 10 > 5);  //true  如果两边都为true,结果就也为true.
            Console.WriteLine(5 < 2 || 8 < 5);   //False 两边结果全部为False，整个结果才为False.
            Console.ReadLine(); 

            //逻辑非 ！
            Console.WriteLine(!(5 > 2));  //False    真的变成假的.
            Console.WriteLine(!(7 < 2));  //true     假的变成真的.
            Console.WriteLine(!(5 < 6));  //False
            Console.ReadLine(); 

            //计算闰年，闰年的条件;年份能被400整除，或者年份能被4整除但不能被100整除。
            int nian = 2868;
            bool runnian =(nian % 400 == 0)||(nian % 4 == 0 && nian % 100 !=0);
            Console.WriteLine(runnian);
            Console.ReadLine();  */

            /*
            //占用符
            string name = "YingHua";
            int age = 18;
            string gender = "女";
            Console.WriteLine("我的名字是:"+name+",我今年"+age+"岁了,"+"我的性别是"+gender); //如果是这样输入会很麻烦
            Console.WriteLine("我的名字是{0},我今年{1}岁了,我的性别是{2}",name,age,gender);  //所以我们使用占用符.,必须按顺序输入，从0这个字符开始.     
            Console.ReadLine();
            
            //用户输入
            string name;
            name=Console.ReadLine();  //Readline: 读 行 读取一行用户的输入.
            Console.WriteLine("我的名字是:{0}",name);
            Console.ReadLine();

            //练习 
            string name;
            string gender;
            string age;
            string likes;
            Console.WriteLine("请输入你的姓名：");
            name = Console.ReadLine();
            Console.WriteLine("请输入你的性别：");
            gender = Console.ReadLine(); 
            Console.WriteLine("请输入你的年龄：");
            age = Console.ReadLine();
            Console.WriteLine("请输入你的喜好：");
            likes = Console.ReadLine();
            Console.WriteLine("我的名字{0}，性别{1}，年龄{2},喜好{3}", name, gender, age,likes) ;
            Console.ReadLine(); */

            /*
            // \n 表示换行
            Console.WriteLine("我的名字叫YingHua,\n性别为女");
            // \" 表示一个英文半角的双引号
            Console.WriteLine("我的名字叫\"YingHua\"性别为女");
            // \t 表示tab键的大空格
            Console.WriteLine("我的名字叫\tYingHua,性别为女");
            // \b 表示BackSpace,退格键，会把前面的一个字符删掉
            Console.WriteLine("我的名字叫\bYingHua,性别为女");
            // \\ 表示一个\ 
            Console.WriteLine("我的名字叫\\YingHua,性别为女");

            //@ 两个作用：1.取消"\"在字符串中的转义作用，使其单纯的表示一个斜杠【多用于路径】  
            string path = @"D:\C#_CODE\06";
            Console.WriteLine(path);
            //2.将字符串按照原格式输出
            Console.WriteLine(@"我的名  字  叫Y  in  g Hua");
            */

            /*
            类型转换
            //隐式转换[自动转换] 条件：1、两种类型兼容  2、原类型要小于目标类型（小的转大的）
            例：int->double   int->float  3个存放的全部都是数值所以可以互相转换
            int num_1 = 10;   
            float num_2;
            double num_3;
            num_2 = num_1;
            num_3 = num_1;
            Console.ReadLine();

            //显示转换[强制转换] 条件：1、两种类型兼容  2、原类型要大于目标类型（大的转小的）
            例：double->int   float->int  3个存放的全部都是数值所以可以互相转换
            float num_1 = 3.5f;
            double num_2 = 3.1415926;
            int num_3 = (int)num_1;  //  3   float转换为int类型后，小数会被舍弃
            int num_4 = (int)num_2;  //  3   double转换为int类型后，小数会被舍弃
            Console.WriteLine("{0}--{1}--{2}--{3}",num_1,num_2,num_3,num_4);
            Console.ReadLine();  

            //表达式的类型转换 1、两个int类型，+ - * / %后，依然是整数类型     2、如果一个操作数为double类型，则整个表达式可提升为double类型。
            int a=10;
            float b=5.6f;
            float c = a + b;
            Console.ReadLine();  

            //Convert类型转换 1、两种类型如果兼容，可使用自动类型转换或强制类型转换  2、两种类型不兼容，如string和int，string和double.这时可用Convert.
            使用条件：“面子上过得去” 
            string num_1 = "3.15";
            string num_2 = "198";   //198是字符串，无法在数学意义进行 + - * /
            double num_3 = Convert.ToDouble(num_1);   //转化为double类型 
            int num_4 = Convert.ToInt32(num_2);       //是整数，直接转化为int类型 
            Console.WriteLine(num_1 + num_2);         //转化前的结果由于是字符串， 运行+号  为相连 
            Console.WriteLine(num_3 + num_4);         //用convert转化之后在相加， 运行+号  为相加
            Console.ReadLine();     

            //练习：加法计算器
            int a;
            int b;
            Console.WriteLine("请输入加数");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入被加数");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            Console.ReadLine();    

            //常量
            int num_1 = 10;   
            const int num_2 = 10;  //常量一旦声明，就不可以二次赋值
            num_1 = 20;
            Console.ReadLine();  */











        }
    }
}
