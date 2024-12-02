[English](./NamingConventions.md "Naming Conventions")

资源命名遵从以下格式

主题名+控件名[+类名+伪类名]+属性名

样例:

ButtonDefaultBackground

SolidButtonDefaultPointeroverBorderThickness

TabItemLeftDefaultPointerOverForeground

### 类与伪类

> 提示：如果没有指定类名，使用Default作为默认值。

> 提示：如果控件的视觉效果与方向有关，方向词将始终作为类名的首项出现。
>
> 如果没有指定方向，方向词将为空，且Top将被静默应用。
> 
> > 样例: 
> >
> > TabStripPlacementProperty of Control ***[TabItem](./MetaOverlay.Avalonia/Controls/TabItem.axaml)***
> > >TabItemLeftCustomClassPointerOverBackground

- 类名总在伪类名前。
- 如果多个类被应用，按字母表排序。
- 如果多个伪类被应用，按字母表排序。