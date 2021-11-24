namespace HomeworkClasses
{
    interface ICombatan
    {
        void Wounds(int dmg);
        int GetAttack(int bonus);
        int MinAttack { get; set; }
        int MaxAttack { get; set; }
    }
}
