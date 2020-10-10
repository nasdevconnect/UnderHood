using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UnderHood.Controls
{
    public class StackLayoutDynamicChildren : StackLayout
    {
        public IList<View> DynamicChildren
        {
            get => (IList<View>)GetValue(DynamicChildrenProperty);
            set => SetValue(DynamicChildrenProperty, value);
        }

        public static readonly BindableProperty DynamicChildrenProperty = BindableProperty.Create(
                                                  propertyName: "DynamicChildren",
                                                  returnType: typeof(IList<View>),
                                                  declaringType: typeof(StackLayoutDynamicChildren),
                                                  defaultValue: new List<View>(), //new Button[] { new Button() { Text = "default button" } }), 
                                                  defaultBindingMode: BindingMode.OneWay,
                                                  propertyChanged: ChildrenChanged);

        private static void ChildrenChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (StackLayoutDynamicChildren)bindable;
            control.Children.Clear();

            IList<View> newChildren = (IList<View>) newValue;

            newChildren.ForEach((v) => control.Children.Add(v));
        }
    }
}
