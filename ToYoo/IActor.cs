namespace ToYoo
{
    public interface IActor<TActor>
        where TActor : IActor<TActor>
    {
        void Do<TToy>(Interaction<TActor, TToy> interaction)
            where TToy : IActor<TToy>;

        bool TryDo<TToy>(Interaction<TActor, TToy> interaction)
            where TToy : IActor<TToy>;

        bool TryDo<TToy>(Interaction<TActor, TToy> interaction, out Rule violatedRule)
            where TToy : IActor<TToy>;
    }
}