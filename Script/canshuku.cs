public class canshu//一般变量
{
	public static bool canshuUIstate = true;//参数界面判断下拉框状态

}

public class minpeijinlv//最小配筋率
{
	public static string hunningtuString="";//混凝土类型名
	public static string gangjinString="";//钢筋类型名
}

public class kugangjinzhijing//钢筋直径
{
	public static string kugangjinzhijingString="";//钢筋直径类型名
}

public class kuweiyiji//位移计
{
	public static bool xialastate = true;//下拉判断
	public static int weiyijiUpNUM = 1;//上序号
	public static int weiyijiDownNUM = 1;//下序号
	public static string weiyijiweizhi = "";//位移计位置
	public static string weiyijijuliName = "";//位移计距离名称
	public static string weiyijishanchu = "";//位移计删除内容名称
}

public class kubaifangyiqi//摆放仪器
{
	public static int xiapanduan = 1;//下方 物件摆设顺序判断
	public static int shangpanduan = 1;//上方 物件摆设顺序判断
	public static bool presspanduan = true;//UI OnPress事件状态判断
	public static bool enterpanduan = false;//鼠标OnMouseEnter事件状态判断
}

public class count//Float计算数值
{
	public static string countliangpohuaixingshi="";//梁破坏形式 计算结果
	public static float countchangdu=0.0f;//长度(L)计算数值
	public static float countzhizuoweizhi=0.0f;//支座位置（a）计算数值
	public static float countjialidianweizhi=0.0f;//加力点位置（L1）计算数值
	public static float countkuandu=0.0f;//宽度（b）计算数值
	public static float countgaodu=0.0f;//高度（h）计算数值
	public static float countgangjingenshu=0.0f;//钢筋根数 计算数值
	public static float countbaohucenghoudu=0.0f;//保护层厚度（dc） 计算数值
	public static float countzuixiaopeijinlv=0.0f;//最小配筋率(p min) 计算数值
	public static float countgangjinzhijing = 0.0f;//钢筋直径（D）计算数值
	public static float countpeijinlv = 0.0f;//配筋率（p）计算数值
	public static float countyibusilongb = 0.0f;//伊布斯隆b 计算数值
	public static float countyibusilong = 0.0f;//伊布斯隆 计算数值
	public static float countaerfa1 = 0.0f;//阿尔法1 计算数值
	public static float countaifuc = 0.0f;//Fc 计算数值
	public static float countaifuy = 0.0f;//Fy 计算数值
	public static float countho = 0.0f;//ho 计算数值
	public static float countjixianwanju = 0.0f;//极限弯矩（Mu）计算数值
	public static float countkejiazaizuidazaihe = 2.0f;//可加载最大载荷（Pmax）计算数值
    public static float countx = 1.0f;//超筋梁极限弯矩x 计算数值   
	public static float countweiyijijuli = 0.0f;//位移计距离（x）数值
	public static float countdangqianhezai = 0.0f;//当前荷载 数值
}
