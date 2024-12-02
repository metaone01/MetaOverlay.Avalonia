Resources are named by following format

Theme+Control[+Class+PseudoClass]+Property

Example:

ButtonDefaultBackground

SolidButtonDefaultPointeroverBorderThickness

TabItemLeftDefaultPointerOverForeground

### Class and PseudoClass

> Hint: If no class is applied, use Default as Class part

> Hint: If control's visual effect depends on orientation, the orientation word will always be first in Class. 
>
> If orientation is undefined, the orientation word will be empty.
> 
> If orientation is Horizontal but Left or Right is unspecified, Left will be silently applied.
>
> If orientation is Vertical but Top or Bottom is unspecified, Top will be silently applied.
>
> > Examples: 
> >
> > TabStripPlacementProperty of Control ***TabItem***
> > >TabItemLeftCustomClassPointerOverBackground

- Classes comes before PseudoClasses
- If multiple Classes are applied, order by alphabet order.
- If multiple PseudoClass are applied, order by alphabet order.