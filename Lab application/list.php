<?php
$servername = "127.0.0.1";
$username = "root";
$password = "";
$dbname = "student";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


$sql = "SELECT * FROM students";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<h2>Registered Students:</h2>";
    echo "<table>";
    echo "<tr><th>ID</th><th>Full Name</th><th>Email</th><th>Gender</th></tr>";

    while ($row = $result->fetch_assoc()) {
        echo "<tr>";
        echo "<td>" . $row["id"] . "</td>";
        echo "<td>" . $row["fullname"] . "</td>";
        echo "<td>" . $row["email"] . "</td>";
        echo "<td>" . $row["gender"] . "</td>";
        echo "</tr>";
    }

    echo "</table>";
} else {
    echo "No registered students.";
}

$conn->close();
?>
