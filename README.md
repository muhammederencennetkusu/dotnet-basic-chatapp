<!DOCTYPE html>
<html>
<head>
    <title>.NET Basic ChatApp</title>
</head>
<body>
    <h1>.NET Basic ChatApp</h1>
    <p>This project is a basic chat application developed using .NET and SignalR. It enables users to chat in real-time using SignalR while storing their data in an SQL database. This README file provides information about the project's structure, requirements, and installation.</p>

    <h2>📝 Features</h2>
    <ul>
        <li><strong>Real-Time Messaging:</strong> Fast and low-latency communication using SignalR.</li>
        <li><strong>User Management:</strong> Each user must log in to participate.</li>
        <li><strong>Message Storage:</strong> Sent and received messages are stored in an SQL database.</li>
        <li><strong>User-Friendly Interface:</strong> Clean and minimalist design for ease of use.</li>
    </ul>

    <h2>📌 Technologies</h2>
    <ul>
        <li><strong>Backend:</strong> .NET Core</li>
        <li><strong>Real-Time Communication:</strong> SignalR</li>
        <li><strong>Database:</strong> SQL Server</li>
        <li><strong>Other:</strong> ASP.NET Core MVC</li>
    </ul>

    <h2>⚙️ Installation</h2>

    <h3>Requirements</h3>
    <ul>
        <li>.NET SDK 6.0 or higher</li>
        <li>SQL Server (Express or higher)</li>
        <li>Git</li>
    </ul>

    <h3>Installation Steps</h3>
    <ol>
        <li>Clone the project from GitHub:
            <pre>```bash
git clone https://github.com/muhammederencennetkusu/dotnet-basic-chatapp.git
cd chatapp-projesi
```</pre>
        </li>
        <li>Install the required dependencies:
            <pre>```bash
dotnet restore
```</pre>
        </li>
        <li>Create a database in SQL Server and add the connection details to the <code>appsettings.json</code> file.</li>
        <li>Set up the database tables using Entity Framework commands:
            <pre>```bash
dotnet ef database update
```</pre>
        </li>
        <li>Run the application:
            <pre>```bash
dotnet run
```</pre>
        </li>
        <li>Open your browser and navigate to <a href="http://localhost:5000">http://localhost:5000</a> to view the application.</li>
    </ol>

    <h2>🚀 Usage</h2>
    <ul>
        <li>On the homepage, log in or register with a username.</li>
        <li>After selecting a username, join the chat room and start sending messages.</li>
        <li>Messages sent will appear instantly on other users' screens.</li>
    </ul>
</body>
</html>
