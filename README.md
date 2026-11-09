# IA Matematica Manuel Dono Araújo

Este documento describe os cambios realizados ao proxecto.

Engadin unha nova escena co meu nome. Nesa escena:

- Reutilicei o script de VillagerDrive para o xogador, cambiando a velocidade de **10** a **5**
- Crei un novo script baseado no de *PigMove* chamado **ZombieMove**, no que modifiquei a magnitude de dirección a 1 para que os NPC aparezcan en riba do xogador en vez de enfrente del.
- Utilicei os prefabs de *Pilgrim* e *Zombie* para as persoaxes da escea.


Aquí podes observar os cambios feitos ao script orixinal:

```csharp
    private void LateUpdate() {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);

        if(direction.magnitude > 1){
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
```