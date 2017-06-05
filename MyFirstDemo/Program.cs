using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDemo  // 命名空间
{
    class Program // 类
    {
        static void Main(string[] args) // Main方法程序入口
        {
            Console.WriteLine("Hello world !"); // 命令以分号结束， Ctrl + F5直接运行
            Console.WriteLine("Hello 你好 !");
            // C#的常量
            const string CITY = "布宜诺斯艾利斯";//常量，城市
            const string NAME = "列奥波尔多·福图纳托·加尔铁里·卡斯特利";//常量，姓名
            Console.WriteLine(CITY + "出生在"+ NAME + "的一个工人家庭");//使用常量
            // C#的变量
            string hobby;//声明变量保存爱好
            hobby = "剑道";//给爱好变量赋值
            Console.WriteLine("我爱好" + hobby);//打印变量
            // 算法——交换
            string boy = "秀丽";//男孩名字
            string girl = "伟强";//女孩名字
            string temp;//中间变量
            temp = boy;//把男孩的名字赋值给temp
            boy = girl;//把女孩的名字赋值给男孩
            girl = temp;//把temp中的名字赋值给女孩
            Console.WriteLine("男孩叫" + boy + " 女孩叫" + girl);
            // 编程练习
            string today;//今天的午饭
            string tomorrow;//明天的午饭
            today = "鱼香肉丝";
            tomorrow = "小鸡炖蘑菇";
            //请在这里补充代码，实现变量today和tomorrow的交换
            string temp1;
            temp1 = tomorrow;
            tomorrow = today;
            today = temp1;
            //打印
            Console.WriteLine("我今天吃{0}，明天吃{1}。", today, tomorrow); // 顺序的交换
            // 打印结果: 今天吃小鸡炖蘑菇，明天吃鱼香肉丝
            // 数据类型
            string name = "曹少钦";//姓名，string类型
            char sex = '男';//性别，char类型
            int age = 19;//年龄，int类型
            double height = 1.72;//身高，double类型
            Console.WriteLine("我叫{0}，是{1}生，今年{2}岁，身高{3}米。", name, sex, age, height);

            //C#的类型转换
            double d = 2.5;
            int x = (int)(d + 1);
            Console.WriteLine(x);
            // C#标识符的命名规则
            int _num1 = 5;//第一个加数
            int _num2 = 7;//第二个加数
            int sum = _num1 + _num2;//求和
            Console.WriteLine("和是{0}", sum);//打印结果

            // 创建2.0分支
            // 创建jin2.0分支

            // C#中没有boolean这种数据类型,
            // double型的2.3赋值给int型变量i，double型精度高，无法自动转换为int类型
            Console.WriteLine((double)3);
            Console.WriteLine((int)3.6);  
            Console.WriteLine((double)3.6);  // 这里转换是多余的！
            // 命名规范--B项int my age错误在变量名中包含了空格 C项 int static错误在用关键字作变量名 D项 int 3th错误在用数字作为变量名开头 

            // C#的算术运算符（一） 加减乘除
            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.Write("我的工资奖金总额是{0}元", salary + prize);
            Console.WriteLine("我的税后收入是{0}元", salary + prize - tax);
            // C#的算术运算符（二） 取余运算符。
            int year = 2015;//年份
            Console.WriteLine(year % 4);//求年份除以4的余数
            // C#的算术运算符（三） ++ --
            int x1 = 5;
            int y = 5;
            int z = 5;
            x1++;
            Console.Write(x1);
            Console.Write(y++);
            Console.Write(z++);
            Console.WriteLine(++z);  // 输出结果为6557
            // C#的比较运算符                         
            double a = 3.5;
            int b = 3;
            Console.WriteLine((int)a >= b);  // 结果是True
        }
    }
}
