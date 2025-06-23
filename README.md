# Example .NET 8 Web Application

This is a simple .NET 8 web application that can be deployed using the Ansible playbook.

## Features

- Simple web API with health check endpoint
- Built with .NET 8
- Ready for deployment with Ansible

## Endpoints

- `GET /` - Hello world message
- `GET /health` - Health check endpoint

## Local Development

```bash
dotnet restore
dotnet run
```

## Deployment with Ansible

Update the `custom-vars.yml` file in the ansible directory:

```yaml
app_git_repo: "https://github.com/your-username/your-repo.git"
app_name: "example-app"
```

Then run:

```bash
cd ansible
ansible-playbook playbook.yml --tags app
``` 