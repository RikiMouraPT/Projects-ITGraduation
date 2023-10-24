tarefas = []

def AdicTarefa():
    tarefa = input("Write the task.\n")
    tarefas.append(tarefa)
    print("Task Added.")

def ListaTarefas():
        print("\n### Task List ###")
        for count, tarefa in enumerate(tarefas, start=1):
            print(f"{count}- {tarefa}")

while True:
  print("\nChoose an option:")     
  print("1 - Write a task.")     
  print("2 - Check the list.")     
  print("3 - Exit")

  choice = input("Choose a number - ")
  print("")

  match choice:
    case "1":
      AdicTarefa()
    case "2":
      ListaTarefas()
    case "3":
        break
