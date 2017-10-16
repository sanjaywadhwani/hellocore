node {
    stage 'Checkout'
        checkout scm

	stage 'use project folder && restore && build'
		dir('webapi/HelloCoreApi/HelloCoreApi') {
			bat 'dotnet restore'
			bat 'dotnet build'
		}
		
	stage('Build image') {
		dir('webapi/HelloCoreApi/HelloCoreApi') {
			app = docker.build("getintodevops/hellonode")
		}
    }

    stage('Test image') {
        /* Volkswagen-type approach */
        app.inside {
            sh 'echo "Hello from container"'
        }
    }
	stage('Push image') {        
        docker.withRegistry('https://registry.hub.docker.com', 'hub.docker.credentials') {
            app.push("${env.BUILD_NUMBER}")
            app.push("jenkins")
        }
    }
}