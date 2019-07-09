namespace Ordi.Reflection
{
    /// <summary>
    /// 设置对象属性或字段值的委托
    /// </summary>
    /// <param name="instance">实例对象</param>
    /// <param name="val">需要设置的值</param>
    public delegate void PropertySetter(object instance, object val);
}
