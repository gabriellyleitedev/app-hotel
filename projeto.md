# AppHotel - Sistema de Reservas 🏨

Aplicação de desktop desenvolvida em **.NET MAUI** para gerenciar reservas de hotel com interface moderna e intuitiva.

## 📋 Descrição

AppHotel é uma aplicação que permite aos usuários:
- Selecionar tipos de acomodação disponíveis
- Escolher datas de check-in e check-out
- Definir quantidade de hóspedes
- Confirmar reservas com visualização de resumo
- Navegar entre telas de forma fluida

## 🛠️ Tecnologias

- **.NET 10** (Target Framework net10.0-windows10.0.19041.0)
- **MAUI** (Multi-platform App UI)
- **C#** 
- **XAML** (Markup Language)

## 📁 Estrutura do Projeto

```
AppHotel/
├── MainPage.xaml           # Tela principal de seleção de reserva
├── MainPage.xaml.cs        # Lógica da página principal
├── Sobre.xaml              # Tela de confirmação e resumo
├── Sobre.xaml.cs           # Lógica da página de confirmação
├── MauiProgram.cs          # Configuração da aplicação
├── App.xaml                # Recursos globais da aplicação
├── AppShell.xaml           # Navegação e shell da app
├── Platforms/              # Código específico por plataforma
│   ├── Android/
│   ├── iOS/
│   ├── MacCatalyst/
│   └── Windows/
├── Resources/              # Imagens, fontes e estilos
│   ├── AppIcon/
│   ├── Fonts/
│   ├── Images/
│   └── Styles/
└── Properties/
    └── launchSettings.json # Configurações de execução
```

## 🚀 Como Executar

### Requisitos
- .NET 10 SDK instalado
- Visual Studio Code ou Visual Studio 2022+

### Passos para rodar

1. **Clonar/Abrir o repositório:**
```bash
cd AppHotel
```

2. **Restaurar dependências:**
```bash
dotnet restore
```

3. **Executar no Windows:**
```bash
dotnet run -f net10.0-windows10.0.19041.0
```

4. **Executar em outras plataformas:**
```bash
# iOS
dotnet run -f net10.0-ios

# Android
dotnet run -f net10.0-android

# macOS Catalyst
dotnet run -f net10.0-maccatalyst
```

## 🎨 Telas

### Página Principal (MainPage)
- Campo de seleção de suíte
- Seletores de data (check-in e check-out)
- Controle de quantidade de hóspedes (Stepper)
- Botão para confirmar reserva
- Link "Sobre o Desenvolvedor"

### Página de Confirmação (Sobre)
- Resumo da reserva com todas as informações
- Tipo de acomodação selecionada
- Período da reserva
- Total de hóspedes
- Botão para fazer nova reserva

## 🎯 Funcionalidades

✅ Seleção de suítes: Master Luxo, Executiva Superior, Standard Comfort  
✅ Calendário interativo para datas  
✅ Controle de hóspedes com Stepper (1-10)  
✅ Navegação entre páginas  
✅ Exibição de resumo de reserva  
✅ Interface responsiva e moderna com tema escuro  

## 🌈 Paleta de Cores

- **Primária:** #D4AF37 (Dourado)
- **Fundo Escuro:** #121212 (Preto profundo)
- **Cards:** #1E1E1E (Cinza muito escuro)
- **Texto Primário:** White (Branco)
- **Texto Secundário:** #A0A0A0 e #707070 (Cinzas)

## 📝 Notas de Desenvolvimento

- A aplicação usa `Border` em vez de `Frame` (obsoleto no .NET 9+)
- Interpolação de strings para formatação de datas
- Event handlers conectados via atributos XAML
- Navegação assíncrona com `Navigation.PushAsync()`

## 🔧 Solução de Problemas

**Erro: "Frame is obsolete"**
- Use `Border` com `Stroke` e `StrokeThickness` em vez de `Frame` com `BorderColor`

**Erro ao limpar projeto:**
- Execute: `Remove-Item -Recurse -Force obj, bin`

**Aplicação não inicia:**
- Verifique se o .NET 10 está instalado: `dotnet --version`
- Limpe e reconstua: `dotnet clean && dotnet run -f net10.0-windows10.0.19041.0`

## 👨‍💻 Autor

Desenvolvido como projeto de estudo em .NET MAUI.

---

**Versão:** 1.0  
**Data:** Maio 2026  
**Status:** ✅ Funcional
