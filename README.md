# PROG7312_POE

# Municipal Services Application: Part 3 Implementation Report

This document details the final implementation of a C# .NET Framework application designed to improve municipal service delivery in South Africa.  It provides residents with a streamlined interface to report issues, access local information, and track service requests.  This report focuses on the core functionalities, technical design choices, and practical usage instructions.  Unexpectedly, the application's success hinges not only on its features but also on the strategic use of advanced data structures, a point we'll explore further.

---

## Features: A User-Centric Approach

The application boasts a clean and intuitive interface, prioritizing ease of use.  Let's examine the fully implemented features:

1. **Main Menu:**  The central hub, providing clear access to:  "Report Issues," "Local Events and Announcements," and "Service Request Status."  Its simplicity belies the sophisticated backend systems supporting it.

2. **Report Issues:** Users can report issues by specifying location, category, and a detailed description.  Image and document attachments are supported, significantly enhancing issue reporting accuracy.  Immediate user feedback confirms successful submission.

3. **Local Events and Announcements:** This section presents local events in a structured format, facilitating easy navigation.  A powerful search function allows filtering by category or date.  Intriguingly, the system leverages user preferences to offer personalized event recommendations – a feature achieved through sophisticated algorithms and data structures.  This personalization significantly enhances user engagement.

4. **Service Request Status:**  Each service request receives a unique identifier, enabling users to track its progress.  The system visualizes complex relationships between requests using advanced data structures, offering unprecedented clarity and efficiency.  This is where the power of graphs and trees truly shines, providing a level of insight previously unavailable.

---

## Technical Overview:

The application's performance rests on a robust foundation of advanced data structures and algorithms.

### Advanced Data Structures:  Optimizing Performance

The choice of data structures was crucial in optimizing performance and scalability.  We employed:

* **Trees:** Binary Search Trees (BSTs) and AVL Trees provide efficient organization and retrieval of service request information.  The AVL tree's self-balancing property ensures optimal search times, even with a large volume of requests.
* **Priority Queues and Heaps:**  These structures manage event priorities, ensuring timely notification and efficient resource allocation.
* **Dictionaries and Sets:**  Used for efficient storage and retrieval of event details and unique categories/dates, respectively.  Their use minimizes redundancy and improves search speed.

### Design Principles:  Prioritizing User Experience

The application adheres to several key design principles:

* **Consistency:**  A unified visual style ensures a seamless user experience.
* **User Feedback:**  Clear messages and progress indicators keep users informed.
* **Engagement:**  Dynamic features encourage active participation and interaction.

---

## Installation and Setup: A Straightforward Process

### Prerequisites

* **Software:** Visual Studio 2019 (or later) with .NET Framework support.
* **Framework:** .NET Framework 4.8 or later.

### Steps to Compile and Run

1. Clone the repository (`git clone https://github.com/Allana-Morris/PROG7312_POE.git`).
2. Open `MunicipalServicesApp.sln` in Visual Studio.
3. Build the project (`Build > Build Solution` or `Ctrl + Shift + B`).
4. Run the application (`F5` for debugging, `Ctrl + F5` for execution).


---

## Usage Instructions:  A Quick Start Guide

Detailed instructions for using each feature are provided within the application itself, however, a brief overview is included here.

1. **Launching the Application:** The main menu offers access to all core features.

2. **Reporting Issues:**  Provide location, category, description, and attachments.

3. **Viewing Local Events:** Search by category or date, and explore personalized recommendations.

4. **Tracking Service Requests:** Enter your unique identifier to view progress and visualizations.
---

## Contact
For further assistance or inquiries, please reach out:
- **Student Name**: [Allana Morris]
- **Student Number**: [ST10204772]

---

## License
This project is licensed under [The Independent Institute of Education (Pty) Ltd 2024].
```
