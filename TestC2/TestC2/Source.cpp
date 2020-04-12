#include <stdio.h>
#include <conio.h>
#include <cstdlib>

#define N 10
#define M 10
typedef int matrix[N][M];
int i = 0;
typedef struct
{
	int x;
	int y;
}location;

location c;
matrix m;

void keylisener()
{
	char c1, c2;
	while (i == 0) 
	{
		if (kbhit()) 
		{
			c1 = getch();
			if (c1 == -32)
			{
				c2 = getch();
				int t1, t2;
				t1 = c1;
				t2 = c2;
				switch (c2)
				{
				case 77:
					printf("rast");
					c.x++;
					if (c.x == M)
						c.x = 0;
					break;
				case 75:
					printf("chap");
					c.x--;
					if (c.x == -1)
						c.x = M-1;
					break;
				case 72:
					printf("bala");
					c.y--;
					if (c.y == -1)
						c.y = N - 1;
					break;
				case 80:
					printf("payin");
					c.y++;
					if (c.y ==N)
						c.y = 0;
					break;
				default:
					printf("%d    %d\n", t1, t2);
				}
				break;
			}
			else if( c1 <= 57 && c1 >= 48 )
			{
				m[c.y][c.x] = c1-48;
			}
				////printf("%d\n", c1);
			
		}
	}
}

void showmatrix()
{
	printf("\n   |                                  |\n");
	for (int i = 0; i<N; i++)
	{
		for (int j = 0; j < M; j++)
		{
			if (j == 0)
				printf("   |  ");
			
			if(i == c.y && j == c.x)
				printf(" %c ", 219);
			else
				printf(" %d ", m[i][j]);

			if(j==M-1)
				printf("  |  ");
		} 
		printf("\n   |                                  |\n");
	}
}

int main()
{
	c.x = 0;
	c.y = 0;
	while (true)
	{
		system("cls");
		showmatrix();
		keylisener();
	}
	

	
	getchar();
	return 0; 
}