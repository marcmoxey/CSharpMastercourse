<<<<<<< HEAD
﻿using UserLibrary.Models;

namespace UserLibrary.BusinessLogic;

public static class PersonExtensions
{
    public static string GetFullName(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName } { person.LastName }";
    }

    public static string GetLoginName(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName.Substring(0, 1) }{ person.LastName }";
    }

    public static string GetInitials(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName.Substring(0, 1) }{ person.LastName.Substring(0,1) }";
    }

    private static void Validate(this PersonModel person)
    {
        if (person is null)
        {
            throw new ArgumentNullException("The PersonModel object cannot be null");
        }

        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
            throw new ArgumentException("The First Name property needs to have a value.");
        }

        if (string.IsNullOrWhiteSpace(person.LastName))
        {
            throw new ArgumentException("The Last Name property needs to have a value.");
        }
    }
}
=======
﻿using UserLibrary.Models;

namespace UserLibrary.BusinessLogic;

public static class PersonExtensions
{
    public static string GetFullName(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName } { person.LastName }";
    }

    public static string GetLoginName(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName.Substring(0, 1) }{ person.LastName }";
    }

    public static string GetInitials(this PersonModel person)
    {
        person.Validate();

        return $"{ person.FirstName.Substring(0, 1) }{ person.LastName.Substring(0,1) }";
    }

    private static void Validate(this PersonModel person)
    {
        if (person is null)
        {
            throw new ArgumentNullException("The PersonModel object cannot be null");
        }

        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
            throw new ArgumentException("The First Name property needs to have a value.");
        }

        if (string.IsNullOrWhiteSpace(person.LastName))
        {
            throw new ArgumentException("The Last Name property needs to have a value.");
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
