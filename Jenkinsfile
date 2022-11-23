pipeline {
	agent any
	parameters {
		string(name: 'SCENARIO_TAG')
	}
	stages {
		stage('Checkout SCM'){
			steps{
			git branch: "master", url: 'https://github.com/cesaralcantarav/SpecFlowTraining.git'
			}
		}
		stage('MSBuild Restore'){
			steps{
				script{
					bat "\"${tool 'MSBuild'}\" /t:restore SpecFlowTraining.sln"
				}
			}
		}
		stage('MS Build Compile'){
			steps{
				script{
					bat "\"${tool 'MSBuild'}\" SpecFlowTraining.sln"
				}
			}
		}
		stage('Execute Tests'){
			steps{
				script{
					bat '"C:\\Program Files (x86)\\NUnit.org\\nunit-console\\nunit3-console.exe" bin/Debug/net6.0/SpecFlowTraining.dll --where "@${SCENARIO_TAG}"'
				}
			}
		}
			
	}
}