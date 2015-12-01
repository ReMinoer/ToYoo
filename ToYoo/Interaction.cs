namespace ToYoo
{
    public delegate void Interaction<TActor, TToy>()
        where TActor : IActor<TActor>
        where TToy : IActor<TToy>;
}