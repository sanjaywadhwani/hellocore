node {
    stage 'Checkout'
        checkout scm

	stage 'use project folder'
		dir('webapi/HelloCoreApi/HelloCoreApi') {
		}
		
    stage 'restore'
        bat 'dotnet restore'

    stage 'build'
        bat 'dotnet build'
}