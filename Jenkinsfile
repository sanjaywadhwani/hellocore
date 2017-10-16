node {
    stage 'Checkout'
        checkout scm

    stage 'restore'
        bat 'dotnet restore'

    stage 'build'
        bat 'dotnet build'
}