node {
    stage 'Checkout'
        checkout scm

	stage 'use project folder && restore && build'
		dir('webapi/HelloCoreApi/HelloCoreApi') {
			bat 'dotnet restore'
			bat 'dotnet build'
		}
}