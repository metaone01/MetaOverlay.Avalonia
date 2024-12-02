[中文](./NamingConventions_CN.md "命名约定")

Resources are named by following format

Theme+Control[+Class+PseudoClass]+Property

Example:

ButtonDefaultBackground

SolidButtonDefaultPointeroverBorderThickness

TabItemLeftDefaultPointerOverForeground

### Class and PseudoClass

> Hint: If no class is applied, use Default as Class part

> Hint: If control's visual effect is related to orientation, the orientation word will always be first in Class. 
>
> If orientation is undefined, the orientation word will be empty, and Top will be silently applied.
>
> > Examples: 
> >
> > TabStripPlacementProperty of Control ***[TabItem](./MetaOverlay.Avalonia/Controls/TabItem.axaml)***
> > >TabItemLeftCustomClassPointerOverBackground

- Classes comes before PseudoClasses
- If multiple Classes are applied, order by alphabet order.
- If multiple PseudoClass are applied, order by alphabet order.