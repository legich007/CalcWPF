   M S B A M L   `   `   `  ����H  DCalculatorWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CalculatorWPFCalculatorWPF  5   	       CalculatorWPF.QEWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CalculatorWPF     5   	   -   5          �Name$  	QEWindow1��5   	    � Title$- 'Квадратное уравнение��5   	   $��347.951��6&   $	��800��67    � WindowStartupLocation$ CenterScreen=�6C    � Topmost .  � WindowStyle$ ThreeDBorderWindow=�6w    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	       �� 
TargetType �� Property	 �� Value��%}   '��       '�� H     �� 5
   
   " ��6   .�5      ��  � ��$	 16(�6*   5      �� 5   
   " ��6   5      5      .��5      � .+�5   
   �� $��ax^2 + bx + c = 0��6   $
��Left=�6,   $��
312,10,0,0q�6G   $	��Top=�6[   �� 5   
   -   5        
 ��Name$
 textBoxA��5      $
��Left=�6$   $��30��6?   $��	99,85,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��150��6�   6�   �� 5   
   -   5        $
 textBoxB��5      $
��Left=�6$   $��30��6?   $��
99,128,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��150��6�   6�   �� 5   
   -   5        $
 textBoxC��5      $
��Left=�6$   $��30��6?   $��
99,173,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��150��6�   6�   �� 5   
   $��a��6   $
��Left=�6   $��	46,80,0,0q�67   $	��Top=�6J    J� RenderTransformOrigin$ 2.184,0.195&�6b   �� 5   
   $��b��6   $
��Left=�6   $��
47,127,0,0q�67   $	��Top=�6K   $ 2.781,-0.113&�6c   �� 5   
   $��c��6   $
��Left=�6   $��
49,172,0,0q�67   $	��Top=�6K   $ 1.878,-0.761&�6c   �� 5   
   $A��;Введите значения коэффициентов:��6   $
��Left=�6:   $��	28,49,0,0q�6U   $	��Top=�6h   �� 5   
   $��Результат��6   $
��Left=�6$   $��
542,49,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $
 richTextBox1��5      $
��Left=�6(   $	��178��6C   $��
506,92,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��255��6�   �� 5   
   -   5         ��Name$ 
CalcButton��5      $��Рассчитать��6%   $
��Left=�6:   $��
28,253,0,0q�6U   $	��Top=�6i   $	��137��6�   $��37��6�   $��20(�6�   �� 5   
   -   5        $ ButtonCancel��5      $��Отмена��6'   $
��Left=�68   $��326,253,0,0q�6S   $	��Top=�6h   $��91��6�   $��37��6�   $��20(�6�   6�   �� 5   
   -   5        $ ButtonClear��5      $��Очистить��6&   $
��Left=�69   $��193,253,0,0q�6T   $	��Top=�6i   $	��102��6�   $��37��6�   $��20(�6�   6�   5!      5"      