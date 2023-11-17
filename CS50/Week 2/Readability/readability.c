#include <cs50.h>
#include <ctype.h>
#include <math.h>
#include <stdio.h>
#include <string.h>

int count_letters(string text);
int count_words(string text);
int count_sentences(string text);
int calculate_index(int letters, int sentences, int words);

int main(void)
{
    // Get Text
    string text = get_string("Text: ");
    // ANALYZE TEXT //
    int letters = count_letters(text);
    int words = count_words(text);
    int sentences = count_sentences(text);
              // printf("%i letters.\n", letters);
    /*DEBUG*/ // printf("%i words.\n", words);
              // printf("%i sentences.\n", sentences);

    // Calculate Index
    int index = calculate_index(letters, sentences, words);
    // Print according to exercice
    if (index >= 16)
    {
        printf("Grade 16+\n");
    }
    else if (index < 1)
    {
        printf("Before Grade 1\n");
    }
    else
    {
        printf("Grade %i\n", index);
    }
}

int calculate_index(int letters, int sentences, int words)
{
    float L = (float) letters / words * 100.0;   // L-> Avg letters/100 words
    float S = (float) sentences / words * 100.0; // S -> Avg sentences/100 wods
    float index = 0.0588 * L - 0.296 * S - 15.8;
    // printf("%f index.\n", index);                      // DEBUG
    int rounded_index = round(index);
    // printf("%i rounded_index.\n", rounded_index);      // DEBUG
    return rounded_index;
}

int count_letters(string text)
{
    int letters = 0;
    int length = strlen(text);
    for (int i = 0; i < length; i++)
    {
        if (isalpha(text[i]) != 0)
        {
            letters++;
        }
    }
    return letters;
}

int count_words(string text)
{
    int words = 1; // Starts with 1 because there's no space in the last word for it to count it, so it needs to be added manually.
    int length = strlen(text);
    for (int i = 0; i < length; i++)
    {
        if (isblank(text[i]) != 0)
        {
            words++;
        }
    }
    return words;
}

int count_sentences(string text)
{
    int sentences = 0;
    int length = strlen(text);
    for (int i = 0; i < length; i++)
    {
        if (text[i] == '.' || text[i] == '!' || text[i] == '?')
        {
            sentences++;
        }
    }
    return sentences;
}
