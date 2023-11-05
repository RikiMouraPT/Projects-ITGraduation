#include <stdio.h>

int main(void)
{
    /*Asking for height:*/
    int height;
    do
    {
        printf("Height: ");
        scanf("%i", &height);
    }
    while (height < 1 || height > 8);

    /*Loop for pyramid*/
    for (int i = 1; i <= height; i++)
    {
        // print spaces on the left side
        for (int j = 0; j < height - i; j++)
        {
            printf(" ");
        }
        // print # on the left side
        for (int j = 0; j < i; j++)
        {
            printf("#");
        }
        // print two spaces after
        printf("  ");
        for (int j = 0; j < i; j++)
        {
            printf("#");
        }
        printf("\n");
    }
}
