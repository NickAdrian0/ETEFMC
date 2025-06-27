/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2025 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "st7735\st7735.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
SPI_HandleTypeDef hspi1;

/* USER CODE BEGIN PV */
// array size is 1152
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_SPI1_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_SPI1_Init();
  /* USER CODE BEGIN 2 */
  ST7735_Init(); // Inicializa o display
  ST7735_FillScreen(BLACK); // Limpa com fundo preto


  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
    {
      int nomeRandom[10], corRandom[10], cor[4] = {RED, BLUE, GREEN, YELLOW}, count = 10, corFundo, acertos = 0;
      char nome[4][9] = {"Vermelho", "  Azul  ", " Verde  ", "Amarelo "}, acertosV[3];

      ST7735_FillScreen(BLACK);
      do {
      ST7735_WriteString(25, 30, "Teste de Stroop", Font_7x10, WHITE, BLACK);
      ST7735_WriteString(15, 60, "Pressione um botao", Font_7x10, WHITE, BLACK); }
      while (!(HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_9) == 0 || HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_10) == 0 || HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_11) == 0 || HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_12) == 0));

      ST7735_FillScreen(BLACK);
      ST7735_WriteString(5, 35, "Vermelho", Font_7x10, RED, BLACK);
      ST7735_WriteString(70, 50, "Azul", Font_7x10, BLUE, BLACK);
      ST7735_WriteString(110, 35, "Verde", Font_7x10, GREEN, BLACK);
      ST7735_WriteString(58, 20, "Amarelo", Font_7x10, YELLOW, BLACK);
      HAL_Delay(3000);

      for (int i = 0; i < count; i++) {
        do {
          corRandom[i] = rand() % 4;
          nomeRandom[i] = rand() % 4;
      } while (corRandom[i] == nomeRandom[i]);

        corFundo = cor[nomeRandom[i]];

        ST7735_FillScreen(corFundo);
        ST7735_WriteString(10, 5, "Acertos: ", Font_7x10, BLACK, corFundo);
        sprintf(acertosV, "%d", acertos);
        ST7735_WriteString(70, 5, acertosV, Font_7x10, BLACK, corFundo);

        ST7735_WriteString(55, 35, nome[nomeRandom[i]], Font_7x10, cor[corRandom[i]], corFundo);

        uint32_t tempoLimite = HAL_GetTick() + 2500;

        while (HAL_GetTick() < tempoLimite) {

          if (HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_9) != 1) {
              if (corRandom[i] == 0) acertos++;
              break;
          }

          if (HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_10) != 1) {
              if (corRandom[i] == 1) acertos++;
              break;
          }

          if (HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_11) != 1) {
              if (corRandom[i] == 2) acertos++;
              break;
          }

          if (HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_12) != 1) {
              if (corRandom[i] == 3) acertos++;
              break;
          }
      }
    }
      ST7735_FillScreen(BLACK);
      ST7735_WriteString(58, 35, "Acertos", Font_7x10, WHITE, BLACK);
      sprintf(acertosV, "%d", acertos);
      ST7735_WriteString(80, 45, acertosV, Font_7x10, WHITE, BLACK);
      HAL_Delay(5000);
}
  /*while (1)
  {
	  int p[10];
	  int cor[4] = {RED, BLUE, GREEN, YELLOW};
	  char nome[4][9] = {"Vermelho", "Azul    ", "Verde   ", "Amarelo "};
	  int count = 9;
	  int corFundo;

	  for (int i = 0; i < count; i++) {
		  int corRandom = rand() % 4;
		  int nomeRandom = rand() % 4;
		  switch (nomeRandom) {
		  case 0:
			  corFundo = RED;
			  break;
		  case 1:
		  	  corFundo = BLUE;
		  	  break;
		  case 2:
		  	  corFundo = GREEN;
		  	  break;
		  case 3:
		  	  corFundo = YELLOW;
		  	  break;
		  }
		  ST7735_FillScreen(corFundo);
		  ST7735_WriteString(55, 35, nome[nomeRandom], Font_7x10, cor[corRandom], corFundo);
		  HAL_Delay(5000);
		  p[0]++;

	  }
  } /*
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */

  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_NONE;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_HSI;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV1;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_0) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief SPI1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_SPI1_Init(void)
{

  /* USER CODE BEGIN SPI1_Init 0 */

  /* USER CODE END SPI1_Init 0 */

  /* USER CODE BEGIN SPI1_Init 1 */

  /* USER CODE END SPI1_Init 1 */
  /* SPI1 parameter configuration*/
  hspi1.Instance = SPI1;
  hspi1.Init.Mode = SPI_MODE_MASTER;
  hspi1.Init.Direction = SPI_DIRECTION_1LINE;
  hspi1.Init.DataSize = SPI_DATASIZE_8BIT;
  hspi1.Init.CLKPolarity = SPI_POLARITY_LOW;
  hspi1.Init.CLKPhase = SPI_PHASE_1EDGE;
  hspi1.Init.NSS = SPI_NSS_SOFT;
  hspi1.Init.BaudRatePrescaler = SPI_BAUDRATEPRESCALER_32;
  hspi1.Init.FirstBit = SPI_FIRSTBIT_MSB;
  hspi1.Init.TIMode = SPI_TIMODE_DISABLE;
  hspi1.Init.CRCCalculation = SPI_CRCCALCULATION_DISABLE;
  hspi1.Init.CRCPolynomial = 10;
  if (HAL_SPI_Init(&hspi1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN SPI1_Init 2 */

  /* USER CODE END SPI1_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(ST7735_CS_GPIO_Port, ST7735_CS_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, ST7735_DC_Pin|ST7735_RES_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin : ST7735_CS_Pin */
  GPIO_InitStruct.Pin = ST7735_CS_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(ST7735_CS_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pins : ST7735_DC_Pin ST7735_RES_Pin */
  GPIO_InitStruct.Pin = ST7735_DC_Pin|ST7735_RES_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : PA9 PA10 PA11 PA12 */
  GPIO_InitStruct.Pin = GPIO_PIN_9|GPIO_PIN_10|GPIO_PIN_11|GPIO_PIN_12;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */
	  //void stringGen (){
	  	//  int corRandom = rand() % 4;
		//  int nomeRandom = rand() % 4;
		//  ST7735_WriteString(0, 0, nome[nomeRandom], Font_7x10, cor[corRandom]), BLACK;
	//  }
/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
