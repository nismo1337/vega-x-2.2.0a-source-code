using System;

// Token: 0x02000015 RID: 21
public class ?0?
{
	// Token: 0x060002B5 RID: 693 RVA: 0x0002B47C File Offset: 0x0002967C
	public static string ?1?(string ?1?)
	{
		int length = ?1?.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = ?1?[i];
			byte b = (byte)((int)c ^ length - i);
			byte b2 = (byte)((int)(c >> 8) ^ i);
			array[i] = (char)((int)b2 << 8 | (int)b);
		}
		return string.Intern(new string(array));
	}
}
