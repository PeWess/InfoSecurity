---
# Front matter
title: "Лабораторная работа #1"
subtitle: "Установка и настройка виртуальной машины"
author: "Критский Сергей Димитриевич"

# Generic otions
lang: ru-RU
toc-title: "Содержание"

# Bibliography
bibliography: bib/cite.bib
csl: pandoc/csl/gost-r-7-0-5-2008-numeric.csl

# Pdf output format
toc: true # Table of contents
toc_depth: 2
lof: false # List of figures
lot: false # List of tables
fontsize: 12pt
linestretch: 1.5
papersize: a4
documentclass: scrreprt
## I18n
polyglossia-lang:
  name: russian
  options:
	- spelling=modern
	- babelshorthands=true
polyglossia-otherlangs:
  name: english
### Fonts
mainfont: PT Serif
romanfont: PT Serif
sansfont: PT Sans
monofont: PT Mono
mainfontoptions: Ligatures=TeX
romanfontoptions: Ligatures=TeX
sansfontoptions: Ligatures=TeX,Scale=MatchLowercase
monofontoptions: Scale=MatchLowercase,Scale=0.9
## Biblatex
biblatex: true
biblio-style: "gost-numeric"
biblatexoptions:
  - parentracker=true
  - backend=biber
  - hyperref=auto
  - language=auto
  - autolang=other*
  - citestyle=gost-numeric
## Misc options
indent: true
header-includes:
  - \linepenalty=10 # the penalty added to the badness of each line within a paragraph (no associated penalty node) Increasing the value makes tex try to have fewer lines in the paragraph.
  - \interlinepenalty=0 # value of the penalty (node) added after each line of a paragraph.
  - \hyphenpenalty=50 # the penalty for line breaking at an automatically inserted hyphen
  - \exhyphenpenalty=50 # the penalty for line breaking at an explicit hyphen
  - \binoppenalty=700 # the penalty for breaking a line at a binary operator
  - \relpenalty=500 # the penalty for breaking a line at a relation
  - \clubpenalty=150 # extra penalty for breaking after first line of a paragraph
  - \widowpenalty=150 # extra penalty for breaking before last line of a paragraph
  - \displaywidowpenalty=50 # extra penalty for breaking before last line before a display math
  - \brokenpenalty=100 # extra penalty for page breaking after a hyphenated line
  - \predisplaypenalty=10000 # penalty for breaking before a display
  - \postdisplaypenalty=0 # penalty for breaking after a display
  - \floatingpenalty = 20000 # penalty for splitting an insertion (can only be split footnote in standard LaTeX)
  - \raggedbottom # or \flushbottom
  - \usepackage{float} # keep figures where there are in the text
  - \usepackage[T2A]{fontenc} 
  - \floatplacement{figure}{H} # keep figures where there are in the text
---

# Цель работы

Целью данной работы является приобретение практических навыков установки операционной системы на виртуальную машину, настройки минимально необходимых для дальнейшей работы сервисов.

# Выполнение лабораторной работы

## Установка и настройка виртуальной машины

Создал новую виртуальную машину, указал размер памяти, имя.

![Имя и тип ОС](image\new_VM.png){#fig:001}

![Объем памяти](image\new_VM_memory.png){#fig:002}

Создал жесткий диск на виртуальной машине, определил его тип и формат хранения.

![Создание жесткого диска](image\new_VM_hard.png){#fig:003}

![Тип жесткого диска](image\new_VM_hard_type.png){#fig:004}

![Формат хранения жесткого диска](image\new_VM_hard_type_2.png){#fig:005}

![Виртуальный жесткий диск](image\new_VM_hard_virtual.png){#fig:006}

## Настройка ОС

Провел первоначальную настройку ОС.

![Настройки языка](image\language.png){#fig:007}

![Настройки дополнительного ПО](image\soft.png){#fig:008}

![Отключение KDUMP](image\kdump.png){#fig:009}

![Имя хоста](image\host.png){#fig:010}

![Корневой пароль](image\root.png){#fig:011}

![Создание пользователя](image\user.png){#fig:012}

![Подключение образа диска гостевой ОС](image\guest.png){#fig:013}

Просмотрел основную информацию о ВМ

![Версия линукс, процессор, оперативная память](image\info_1.png){#fig:014}

![Гипервизор, файловая система](image\info_2.png){#fig:015}

# Выводы

Я приобрел практические навыки по настройке ВМ и установке ОС.
