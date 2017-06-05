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
        }
    }
}
