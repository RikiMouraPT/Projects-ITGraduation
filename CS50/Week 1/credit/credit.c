#include <math.h>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
    // Initialize variables
    long credit_card;
    printf("Credit Card: ");
    scanf("%ld", &credit_card);

    long credit_card_check;
    credit_card_check = credit_card; // Used to check the card type.

    long credit_card_remainder;
    bool want_number = false;
    int sum1 = 0;
    int sum2 = 0;

    // Loop through the credit card number
    while (credit_card > 0)
    {
        credit_card_remainder = credit_card % 10;

        if (want_number)
        {
            // Double every second digit
            credit_card_remainder = credit_card_remainder * 2;
            if (credit_card_remainder >= 10)
            {
                while (credit_card_remainder > 0)
                {
                    int credit_card_remainder_remainder;
                    credit_card_remainder_remainder = credit_card_remainder % 10;
                    sum1 = sum1 + credit_card_remainder_remainder;
                    credit_card_remainder = credit_card_remainder / 10;
                }
            }
            else
            {
                sum1 = sum1 + credit_card_remainder;
            }
        }
        else
        {
            sum2 = sum2 + credit_card_remainder;
        }
        want_number = !want_number;
        credit_card = credit_card / 10;
    }

    // Calculate the Luhn algorithm checksum
    int sum_check;
    sum_check = sum1 + sum2;
    sum_check = sum_check % 10;

    // Convert the credit card number to a string to check its length
    char credit_card_check_str[16];
    sprintf(credit_card_check_str, "%ld", credit_card_check);
    size_t credit_card_check_length = strlen(credit_card_check_str);

    // Extract the first two digits to determine the card type
    credit_card_check = credit_card_check / pow(10, credit_card_check_length - 2);

    // Check card validity and type
    if (sum_check == 0)
    {
        if (credit_card_check_length == 15 && (credit_card_check == 34 || credit_card_check == 37))
        {
            printf("AMEX\n"); // American Express card
        }
        else if (credit_card_check_length == 16 && (credit_card_check == 51 || credit_card_check == 52 || credit_card_check == 53 ||
                                                    credit_card_check == 54 || credit_card_check == 55))
        {
            printf("MASTERCARD\n"); // MasterCard
        }
        else if ((credit_card_check_length == 13 || credit_card_check_length == 16) &&
                 (credit_card_check >= 40 && credit_card_check <= 49))
        {
            printf("VISA\n"); // Visa card
        }
        else
        {
            printf("INVALID\n"); // Invalid card
        }
    }
    else
    {
        printf("INVALID\n"); // Invalid card
    }
}
